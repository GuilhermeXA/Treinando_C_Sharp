# Solicite o número de termos da sequência que o usuário deseja
n = int(input("Digite o número de termos da sequência de Fibonacci: "))

# Inicialize os dois primeiros termos da sequência
a, b = 0, 1

# Inicialize uma lista para armazenar os termos da sequência
fibonacci = [a, b]

# Calcule os termos restantes
for i in range(2, n):
    proximo = a + b
    fibonacci.append(proximo)
    a, b = b, proximo

# Imprima a sequência de Fibonacci
print("Sequência de Fibonacci:")
for termo in fibonacci:
    print(termo, end=" ")
