//Problem 1
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
//renderAllContinents(continents);
//renderSingleContinent(continents['Europe']);
//renderSingleCountry(continents['Europe']['countries']['Bulgaria']);

function renderAllContinents(continents) {
    for(let key in continents){
        let continent=continents[key];
        console.log(continent['name']);
    }
}
function renderSingleContinent(continent) {
    console.log(continent['name']);

    console.log("Countries");

    for(let key in continent['countries']){
        let country=continent['countries'][key];
        console.log("$$$"+country['name']);
    }
}

function renderSingleCountry(country) {
    console.log(country['name']);

    console.log('Capital: '+country['capital']);
    console.log('Official Language: '+country['officialLanguage']);
    console.log('Population: '+country['population']);
    console.log('Area: '+country['area']+" km2");
    console.log('Political Status: '+country['politicalStatus']);
    if(country['politicalStatus']==='Republic'){
        console.log("President: "+country['president']);
    }else{
        console.log("Monarch: "+country['monarch'])
    }
    console.log('Official Currency: '+country['officialCurrency']);
}
//end


//Problem 2

let continentsForHTML = {
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

function renderAllContinentsInHTML(continents) {
    for (let key in continents) { // if have more than >1 continent in continents
        let continent = continents[key];

        let continentDiv = $('<div class="continent">')
            .append('<h5 class="continent-title">' + continent['name'] + '</h5>'); // each one continentName

        $('.continents').append(continentDiv); // add every continent to continents

        // renderSingleContinentInHTML(continent); //for problem 2
    }
}
function renderSingleContinentInHTML(continent) {
    //Render Continent Data
    let countriesDiv=$('<div class="countries">');
    let countriesSelect=$('<select class="dropdown-select">')
        .append('<option disabled selected value> -- select an option -- </option>');

    let countries=continent['countries'];

    for(let key in countries){
        let country=countries[key];
        countriesSelect.append('<option value="'+country['name']+'">'+country['name']+'</option>');
        // renderSignleCountryInHTML(country);
    }



    //Render Image
    let imageDiv=$('<div class="continent-image">')
        .append('<img src="images/'+continent['name'].toLowerCase() +'.png">')

    $('.continent-data')
        .append('<h2 class="continent-title">'+continent['name']+'</h2>')
        .append('<h3 class="countries-title">Countries</h3>')
        .append(countriesDiv.append(countriesSelect))
        .append(imageDiv);

}
function renderSignleCountryInHTML(country) {
    //Render Country
    let countryTitle=$('<div class="country-title">')
        .append('<h2>'+country['name']+'</h2>');

    let countryData=$('<div class="country-data">')
        .append('<div class="country-capital"><strong>Capital:</strong> <div>'+country['capital']+'</div></div>')
        .append('<div class="country-official-language"><strong>Official Language:</strong><div>'+country['officialLanguage']+'</div></div>')
        .append('<div class="country-population"><strong>Population:</strong> <div>'+country['population']+'</div></div>')
        .append('<div class="country-area"><strong>Area:</strong> <div>'+country['area']+' km<sup>2</sup></div></div>')
        .append('<div class="country-political-status"><strong>Political Status:</strong><div>'+country['politicalStatus']+'</div></div>')
        .append(
            country['politicalStatus']==='Republic'
                ?'<div class="country-president"><strong>President:</strong><div>'+country['president']+'</div></div>'
                :'<div class="country-monarch"><strong>Monarch:</strong><div>'+country['monarch']+'</div></div>')
        .append('<div class="country-official-currency"><strong>Official Currency:</strong><div>LEV(BGN)</div></div>')

    $('.continent-country').append(countryTitle).append(countryData);
}
function renderDataInHTML(continents) {
    renderAllContinentsInHTML(continents);
}
//renderDataInHTML(continentsForHTML);


//Problem 3


function showData() {
    $('.continent-data').show();
    $('.continent-country').show();
}

function hideData() {
    $('.continent-data').hide();
    $('.continent-country').hide();
}

function clearData() {
    $('.continent-data').empty();
    $('.continent-country').empty();
}

function attachEvents(continents) {
    renderAllContinentsInHTML(continents);
    attachCountries(continents);
}

function attachCountries(continents){
    $('.continent').click($('.continent-title'), function (e) {
        e.preventDefault();
        clearData();

        if($(this).hasClass('shown')){
            $(this).removeClass('shown');
            hideData();
            clearData();
        }
        else {
            $(this).parent().parent().find('.shown').removeClass('shown');
            $(this).addClass('shown');
            let continentName=$(this).text();
            console.log(continentName);
            renderSingleContinentInHTML(continents[continentName]);
            showData();
        }
    });
}

attachEvents(continents);