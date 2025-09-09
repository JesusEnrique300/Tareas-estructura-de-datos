
let arr = [10, 20, 30, 40, 50];


const readline = require("readline").createInterface({
  input: process.stdin,
  output: process.stdout
});

readline.question("Ingresa el número a buscar: ", input => {
  let valor = parseInt(input);
  let encontrado = false;

  for (let i = 0; i < arr.length; i++) {
    if (arr[i] === valor) {
      console.log("Número encontrado en la posición " + i);
      encontrado = true;
      break;
    }
  }

  if (!encontrado) {
    console.log("Número no encontrado.");
  }

  readline.close();
});




