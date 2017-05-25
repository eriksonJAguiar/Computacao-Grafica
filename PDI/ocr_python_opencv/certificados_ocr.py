import PIL.Image
import numpy as np
import cv2
from matplotlib import pyplot as plt
import pytesseract
import nltk
import sys
from tkinter import *
from tkinter.ttk import *
import _thread

valores = []

class App(Frame):

    def __init__(self, parent):
        Frame.__init__(self, parent)
        self.CreateUI()
        self.LoadTable()
        self.grid(sticky = (N,S,W,E))
        parent.grid_rowconfigure(0, weight = 1)
        parent.grid_columnconfigure(0, weight = 1)

    def CreateUI(self):
        tv = Treeview(self)
        tv['columns'] = ('curso', 'dias', 'horas','organizador')
        tv.heading("#0", text='Nome', anchor='w')
        tv.column("#0", anchor="w")
        tv.heading('curso', text='Curso')
        tv.column('curso', anchor='center', width=100)
        tv.heading('dias', text='Dias')
        tv.column('dias', anchor='center', width=100)
        tv.heading('horas', text='Horas')
        tv.column('horas', anchor='center', width=100)
        tv.heading('organizador', text='Organizardor')
        tv.column('organizador', anchor='center', width=100)
        tv.grid(sticky = (N,S,W,E))
        self.treeview = tv
        self.grid_rowconfigure(0, weight = 1)
        self.grid_columnconfigure(0, weight = 1)

    def LoadTable(self):
        self.treeview.insert('', 'end', text=valores[4], values=(valores[3],
                             valores[0], valores[1],valores[3]))



def levenshtein(a,b):
    #"Calculates the Levenshtein distance between a and b."
    n, m = len(a), len(b)
    if n > m:
        # Make sure n <= m, to use O(min(n,m)) space
        a,b = b,a
        n,m = m,n
        
    current = range(n+1)
    for i in range(1,m+1):
        previous, current = current, [i]+[0]*n
        for j in range(1,n+1):
            add, delete = previous[j]+1, current[j-1]+1
            change = previous[j-1]
            if a[j-1] != b[i-1]:
                change = change + 1
            current[j] = min(add, delete, change)
            
    return current[n]        


##Processamento da Imagem

##printar Tela da Imagem
def window_img(img):
    plt.imshow(img,cmap='gray',interpolation = 'bicubic')
    plt.xticks([]), plt.yticks([])  # to hide tick values on X and Y axis
    plt.show()

def processingImg(caminho,newfile):

    im = cv2.imread(caminho)

    gray = cv2.cvtColor(im, cv2.COLOR_BGR2GRAY)  

    _,th = cv2.threshold(gray,0,255,cv2.THRESH_BINARY+cv2.THRESH_OTSU)

    kernel = cv2.getStructuringElement(cv2.MORPH_CROSS,(2,2))

    open = cv2.morphologyEx(th, cv2.MORPH_OPEN, kernel)

    _,th2 = cv2.threshold(open,0,127,cv2.THRESH_BINARY_INV)

    height = np.size(th2, 0)
    width = np.size(th2, 1)

    crop_img = th2[350:(height-350),:width]

    cv2.imwrite(newfile,crop_img)

    return crop_img

##Extração com OCR
def ocr(caminho):
    str_text = pytesseract.image_to_string(PIL.Image.open(caminho))
    return str_text

##Conjunto de métodos para o reconhecimento do texto
def removeStopwords(texto):
    #remove stopwords
    filtrado = [w for w in nltk.word_tokenize(texto) if not w in nltk.corpus.stopwords.words('portuguese')]

    return filtrado

def verificaSimilaridade(str,tokens):

    for t in tokens:
        if levenshtein(t,str) < 2:
            return t

def getDays(tokens):
    word_day = verificaSimilaridade('dias',tokens)

    days = ''

    i = 0
    for t in tokens:
        if t == word_day:
            j = i + 1
            while tokens[j] != ',' :
                days += tokens[j] + ' '
                j += 1 

            return days

        i += 1

def getOrganizador(tokens):
    
    word_organizador = []

    word_organizador.append(verificaSimilaridade('durante',tokens))
    word_organizador.append(verificaSimilaridade('realizado',tokens))


    organizador = ''
    i = 0
    for t in tokens:
        
        if t in word_organizador:
      
            organizador += tokens[i+1] +' '+ tokens[i+2] + ' ' + tokens[i+3]

            return organizador

        i += 1

def getCurso(tokens):
    word_curso = []

    word_curso.append(verificaSimilaridade('curso',tokens))
    word_curso.append(verificaSimilaridade('minicurso',tokens))

    curso = ''
    
    i = 0
    for t in tokens:
        if t == word_curso[0] or t == word_curso[1]:
            j = i + 1
            while tokens[j] != ',':
                curso += tokens[j] + ' '
                j += 1

            return curso

        i += 1


def getHoras(tokens):
 
    hora = verificaSimilaridade('horas',tokens)

    horas = ''   
    
    i = 0
    for t in tokens:
        if t == hora:
            txt = '{0}'.format(tokens[i-1])
            if (not txt.isdigit()):
                j = i-1
                while tokens[j] != '(':
                    horas = tokens[j]
                    j -= 1

                return horas        

            horas = txt    
            
            return horas       

        i += 1
def processingText(str_text):
    
    str_text = str_text.lower()

    sem_stopwords = removeStopwords(str_text)

    days = getDays(sem_stopwords)    
    hora = getHoras(sem_stopwords)
    curso = getCurso(sem_stopwords)
    organizador = getOrganizador(sem_stopwords)

    json_file = {
        'organizador': organizador,
        'horas': hora,
        'curso': curso,
        'data':days
    }

    valores.append(days)
    valores.append(hora)
    valores.append(curso)
    valores.append(organizador)

    return json_file

def main():

   root = Tk()
   App(root)
   root.mainloop()


##metodo principal
if __name__ == '__main__':
    
    filename = "certificados/campus"
    extension = '.png'
    file = filename + extension
    newfile = filename+"_crop.png"

    img = processingImg(file,newfile)
    str_text = ocr(newfile)

    processingText(str_text)

    #window_img(img)

    valores.append('Charlinhos')

    _thread.start_new_thread(window_img,(img,))
    _thread.start_new_thread(main())

    
    

   


