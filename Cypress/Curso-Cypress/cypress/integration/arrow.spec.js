it('nada agora', function () { })

/* function soma(a, b) {
    return a + b;
} */

/* const soma = function(a, b){
    return a + b
} */


//Arrow function simples
/* const soma = (a, b) => {
    return a + b
} */

//ou assim
/* const soma = (a, b) => a +b */

//Variações do Arrow function
//const soma = (a) => a+a
//ou 
//const soma = a => a+a
const soma = () => 5+5


console.log(soma(1, 4))


it('a function test...', function() {
    console.log('function', this)
})


it('a arrow  test...', () =>  {
    console.log('aroww', this)
})