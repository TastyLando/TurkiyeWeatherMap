//function fetchWeatherData(city) {
//    const apiKey = '8161e4ef4d594891969152916242511';
//    const apiUrl = `https://api.weatherapi.com/v1/current.json?key=${apiKey}&q=${city}&lang=tr`;

//    fetch(apiUrl)
//        .then(response => response.json())
//        .then(data => {
//            // Hava durumu verilerini işleyin ve gösterin
//            const weatherBox = document.getElementById('weatherBox');
//            weatherBox.innerHTML = `
//                <h3>${data.location.name}</h3>
//                <p>${data.current.condition.text}</p>
//                <p>Sıcaklık: ${data.current.temp_c}°C</p>
//                <img src="${data.current.condition.icon}" alt="Hava Durumu İkonu">
//            `;
//            weatherBox.style.display = 'block';
//        })
//        .catch(error => console.error('Hava durumu verisi alınamadı:', error));
//}
