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
    },
    Asia: {
        name: "Asia",
        countries: {
            Russia: {
                name: "Russia",
                capital: "Moscow",
                officialLanguage: "Russian",
                population: 144463451,
                area: 17075200,
                politicalStatus: "Republic",
                president: "Vladimir Putin",
                officialCurrency: "Russian ruble(RUB)"
            },
            China: {
                name: "China",
                capital: "Beijing",
                officialLanguage: "Chinese",
                population: 1403500365,
                area: 9596961,
                politicalStatus: "Republic",
                president: "Xi Jinping",
                officialCurrency: "Renminbi(CNY)"
            }
        }
    }
};

let continentsForHtml = {
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


//problemHTML 2
function renderDataInHTML(continents) {
    for(let key in continents) {
        let continent = continents[key];

        let continentDiv = $('<div class="continent">')
            .append('<h5 class="continent-title">' + continent['name'] + '</h5>');

        $('.continent').append(continentDiv);

        let countriesDiv = $('<div class="countries">');

        let dropdownSelect = $('<select class=="dropdown-select">')
            .append('<option disabled selected value> -- select an option -- </option>')
        let countries = continent['countries'];
        for(let key in countries){
            let country = countries[key];
            dropdownSelect
                .append('<option value="'+ country['name'] + '">' + country['name'] + '</option>');
        }
        $('.continent-data')
            .append('<h2 class="continent-title">' + continent['name'] + '</h2>')
            .append('<h3 class="countries-title">Countries</h3>)')
            .append(countriesDiv);

    }
}


//renderAllContinents(continents);
//renderSingleContinent(continents['Europe']);
//renderSingleCountry(continents['Europe']['countries']['Bulgaria']);

renderDataInHTML(continentsForHtml);
