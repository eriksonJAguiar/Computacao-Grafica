from PIL import Image
import numpy as np
import cv2
from matplotlib import pyplot as plt
import pytesseract
import sys
from PyQt5 import QtCore,QtGui,QtWidgets,uic


##Variaveis Globais
#stopwordsAux = "a, agora, ainda, alguém, algum, alguma, algumas, alguns, ampla, amplas, amplo, amplos, ante, antes, ao, aos, após, aquela, aquelas, aquele, aqueles, aquilo, as, até, através, cada, coisa, coisas, com, como, contra, contudo, da, daquele, daqueles, das, de, dela, delas, dele, deles, depois, dessa, dessas, desse, desses, desta, destas, deste, deste, destes, deve, devem, devendo, dever, deverá, deverão, deveria, deveriam, devia, deviam, disse, disso, disto, dito, diz, dizem, do, dos, e, é, ela, elas, ele, eles, em, enquanto, entre, era, essa, essas, esse, esses, esta, está, estamos, estão, estas, estava, estavam, estávamos, este, estes, estou, eu, fazendo, fazer, feita, feitas, feito, feitos, foi, for, foram, fosse, fossem, grande, grandes, há, isso, isto, já, la, lá, lhe, lhes, lo, mas, me, mesma, mesmas, mesmo, mesmos, meu, meus, minha, minhas, muita, muitas, muito, muitos, na, não, nas, nem, nenhum, nessa, nessas, nesta, nestas, ninguém, no, nos, nós, nossa, nossas, nosso, nossos, num, numa, nunca, o, os, ou, outra, outras, outro, outros, para, pela, pelas, pelo, pelos, pequena, pequenas, pequeno, pequenos, per, perante, pode, pude, podendo, poder, poderia, poderiam, podia, podiam, pois, por, porém, porque, posso, pouca, poucas, pouco, poucos, primeiro, primeiros, própria, próprias, próprio, próprios, quais, qual, quando, quanto, quantos, que, quem, são, se, seja, sejam, sem, sempre, sendo, será, serão, seu, seus, si, sido, só, sob, sobre, sua, suas, talvez, também, tampouco, te, tem, tendo, tenha, ter, teu, teus, ti, tido, tinha, tinham, toda, todas, todavia, todo, todos, tu, tua, tuas, tudo, última, últimas, último, últimos, um, uma, umas, uns, vendo, ver, vez, vindo, vir, vos, vós"
#stopwords = stopwordsAux.split(',')


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

def processingImg(caminho):

    im = cv2.imread(caminho)

    gray = cv2.cvtColor(im, cv2.COLOR_BGR2GRAY)

    _,th = cv2.threshold(gray,0,255,cv2.THRESH_BINARY+cv2.THRESH_OTSU)

    kernel = cv2.getStructuringElement(cv2.MORPH_CROSS,(2,2))

    open = cv2.morphologyEx(th, cv2.MORPH_OPEN, kernel)

    _,th2 = cv2.threshold(open,0,127,cv2.THRESH_BINARY_INV)

    height = np.size(th2, 0)
    width = np.size(th2, 1)

    crop_img = th2[350:(height-350),:width]

    cv2.imwrite(caminho,crop_img)

    return crop_img

##Extração com OCR
def ocr(caminho):
    str_text = pytesseract.image_to_string(Image.open(caminho))
    return str_text

##printar Tela da Imagem
def window_img(img):
    plt.imshow(img,cmap='gray',interpolation = 'bicubic')
    plt.xticks([]), plt.yticks([])  # to hide tick values on X and Y axis
    plt.show()




##Reconhecimento do Texto

#tokens = str_text.split(' ')

#preprocess(str_text)

#participante = ['participacao','certificamos','dias']

#curso = ['curso','mincurso']

#organizador = ['realizado','universidade','instituto',]


#for t in tokens:
#    print(t)

#datas = []
#minicurso = ''
#dias = []
#horas = ''

#i = 0

#for token in tokens:
#	if(token.isdigit()):
#		datas.append(token)
	
#	if(levenshtein(token,'minicurso') < 5):
#		minicurso = tokens[i+1]

	

#	i += 1

##metodo principal
if __name__ == '__main__':
    filename = "certificados/campus"
    extension = '.png'
    file = filename + extension
    newfile = filename+"_process.png"

    img = processingImg(file)
    str_text = ocr(newfile)
    print(str_text)


