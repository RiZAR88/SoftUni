let commands = [
   'add 3',
   'add 5',
   'remove 1',
    'add 2'
];

let emptyArray = [];

for(let command of commands){
    let splitedCommand = command.split(' ');
    if(splitedCommand[0] === 'add'){
        emptyArray.push(splitedCommand[1])
    }
    else if(splitedCommand[0] === 'remove'){
        emptyArray.splice(splitedCommand[1])
    }
}
console.log(emptyArray);