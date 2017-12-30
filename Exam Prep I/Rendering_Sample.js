let location = {
    name: 'Izgrev',
    longitude: '95.243',
    latitude: '94.231',
    pokemons: {
        0: {
            name: 'Pikachu',
            power: 2000,
            evolvedFrom: 'none',
            evolvesTo: 'Raichu'
        },
        1: {
            name: 'Wartortle',
            power: 500,
            evolvedFrom: 'Squirtle',
            evolvesTo: 'Blastoise'
        },
        2: {
            name: 'CherryBerry',
            power: 9999,
            evolvedFrom: 'Cherry',
            evolvesTo: 'Berry'
        }
    }
};
function renderData(location) {
    console.log("Location: " + location.name);
    console.log(`Longitude: ${location.longitude}  Latitude: ${location.latitude}`);
    console.log("Pokemons:");
    for (let i = 0; i <= 1000; i++) {
        if(location.pokemons[i] === undefined) break;
        let nextPokemon = location.pokemons[i];
        console.log("###Name: " + nextPokemon.name);
        console.log("###Power: " + nextPokemon.power);
        console.log("###Evolved From: " + nextPokemon.evolvedFrom);
        console.log("###Evolves To: " + nextPokemon.evolvesTo);
    }
}
renderData(location);
