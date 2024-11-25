from pdf2image import convert_from_path, convert_from_bytes

img = convert_from_path("data/2019 | Marketing de Conteúdo.pdf", dpi=200)

for imgs in img:
    imgs.save("data/2019 | Marketing de Conteúdo.png", "PNG")