/*it ('sem testes, ainda', () => {})

//const getSomething = () => 10;

 const getSomething = callback => {
    setTimeout (() => {
        callback(12);
    }, 1000)
}

const system = () => {
    console.log('init');
    getSomething(some => {
        console.log( `Something is ${some}`);
        console.log('end');
    })
} */

//promises
/* it('sem testes, ainda', () => { })

const getSomething = () => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(13);
        }, 1000)
    })

}

const system = () => {
    console.log('init');
    getSomething().then(some => {
        console.log(`Something is ${some}`)
    })
        console.log('end');
    
}

system(); */


//async await - Não utilizar com o cypress
it('sem testes, ainda', () => { })

const getSomething = () => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(13);
        }, 1000)
    })

}

const system = async () => {
    console.log('init');
    const some = await  getSomething()
    console.log(`Something is ${some}`)
    console.log('end')
}

system();