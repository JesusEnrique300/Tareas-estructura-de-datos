// Lista inicial
let numeros = [10, 20, 30, 40, 50];

// 1. Recorrer e imprimir
console.log("Elementos iniciales:");
for (let n of numeros) {
    process.stdout.write(n + " ");
}
console.log();

// 2. Insertar elemento
numeros.push(60);

console.log("Elementos despues de insertar 60:");
for (let n of numeros) {
    process.stdout.write(n + " ");
}
console.log();

// 3. Buscar un elemento elegido por el usuario
const readline = require("readline").createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.question("Ingrese el numero a buscar: ", (input) => {
    let buscar = parseInt(input);
    let encontrado = false;

    for (let n of numeros) {
        if (n === buscar) {
            console.log("Elemento encontrado: " + n);
            encontrado = true;
            break;
        }
    }

    if (!encontrado) {
        console.log("Elemento no encontrado.");
    }
    readline.close();
});




