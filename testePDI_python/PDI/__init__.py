from PIL import Image, ImageDraw

PIL_Version = Image.VERSION

img_filename = "../img/coelho.jpeg"
im = Image.open(img_filename)

pixel = im.load()

rgb = pixel[0,0]

print(rgb)

draw = ImageDraw.Draw(im)
draw.line((0, 0) + im.size, fill=128)
#draw.line((0, im.size[1], im.size[0], 0), fill=128)
del draw

# write to stdout
im.save("../img/coelho2.png", "PNG")

img = Image.open('../img/coelho.jpeg').convert('L')
img.save('../img/coelho3.png')