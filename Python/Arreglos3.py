arr = ['A', 'B', 'C', 'D', 'E']
valor = input("Ingresa la letra a buscar: ")
encontrado = False

for i, letra in enumerate(arr):
    if letra == valor:
        print(f"Encontrado en la posición {i}")
        encontrado = True
        break

if not encontrado:
    print("No se encontró la letra.")





