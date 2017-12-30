let continents = {
    Europe: {
        name: "Europe",
        countries: {
            Bulgaria: {
                name: "Bulgaria",
                capital: "Sofia",
                officialLanguage: "Bulgarian",
                population: 7000000,
                area: 111000,
                politicalStatus: "Republic",
                president: "Rumen Radev",
                officialCurrency: "LEV(BGN)"
            },
            Vatican: {
                name: "Vatican",
                capital: "Vatican City",
                officialLanguage: "Italian",
                population: 1000,
                area: 0.44,
                politicalStatus: "Monarchy",
                monarch: "Francis",
                officialCurrency: "Euro(EUR)"
            }
        }
    }
};
//problem 1
function renderAllContinents(continents) {
    for(let key in continents){
        let continet = continents['key'];
        console.log(continents['name']);
    }
}
function renderSingleContinent(continent) {
    console.log(continent['name']);

    console.log('Countries');
    let countries = continent['countries'];
    for(let key in countries){
        let country = countries[key];
        console.log('$$$' + country['name']);
    }
}
function renderSingleCountry(country) {
    console.log(country['name']);
    console.log('Capital: ' + country['capital']);
    console.log('Official Language: ' + country['officialLanguage']);
    console.log('Population: ' + country['population']);
    console.log('Area: ' + country['area'] + ' km2');
    console.log('Political Status: ' + country['politicalStatus']);
    if(country['politicalStatus'] === 'Republic'){
        console.log('President: ' + country['president']);
    }
    else {
        console.log('Monarch:' + country['monarch']);
    }
    console.log('Official Currency: ' + country['officialCurrency']);

}

//problem 2

//renderAllContinents(continents);
renderSingleContinent(continents['Europe']);
//renderSingleCountry(continents['Europe']['countries']['Bulgaria']);
