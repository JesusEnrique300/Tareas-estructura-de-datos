# Lista inicial
numeros = [10, 20, 30, 40, 50]

# 1. Recorrer e imprimir
print("Elementos iniciales:")
for n in numeros:
    print(n, end=" ")
print()

# 2. Insertar elemento
numeros.append(60)

print("Elementos despues de insertar 60:")
for n in numeros:
    print(n, end=" ")
print()

# 3. Buscar un elemento elegido por el usuario
buscar = int(input("Ingrese el numero a buscar: "))

encontrado = False
for n in numeros:
    if n == buscar:
        print(f"Elemento encontrado: {n}")
        encontrado = True
        break

if not encontrado:
    print("Elemento no encontrado.")




