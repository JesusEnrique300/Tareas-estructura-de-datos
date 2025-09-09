let arr = [
    [1,2,3],
    [4,5,6],
    [7,8,9]
];

for(let j = 0; j < arr[0].length; j++) { // Columnas
    let fila = "";
    for(let i = 0; i < arr.length; i++) { // Filas
        fila += arr[i][j] + " ";
    }
    console.log(fila);
}


