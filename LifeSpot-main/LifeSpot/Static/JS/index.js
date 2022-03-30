setTimeout(() =>
    alert("Подпиcывайтесь на наш Telegram @lifespot!" ),
30000);


function filterVideoContent()
{   
    let valueInput = inputParseFunction();

    let videoContainers = document.getElementsByClassName('video-container');
    
    for ( let i = 0; i < videoContainers.length; i++ )
    {                 
        let videoName = videoContainers[i].getElementsByTagName('p')[0].textContent.toLowerCase();

        if(!videoName.includes(valueInput))
        {
            videoContainers[i].style.display = 'none';
        }
        else
        {
            videoContainers[i].style.display = 'inline-block';
        }
    }
}


/*
* Сохранение данных сессии сразу при заходе пользователя на страницу
*
* */
function handleSession (logger, checker){
  
    // Проверяем дату захода и проставляем, если новый визит
    if(window.sessionStorage.getItem("startDate") == null){
        window.sessionStorage.setItem("startDate", new Date().toLocaleString())
    }
  
    // Проверяем userAgent и проставляем, если новый визит
    if(window.sessionStorage.getItem("userAgent") == null){
        window.sessionStorage.setItem("userAgent", window.navigator.userAgent)
    }
  
    // Проверяем возраст и проставляем, если новый визит
    if(window.sessionStorage.getItem("userAge") == null){
        let input = prompt("Пожалуйста, введите ваш возраст?");
        window.sessionStorage.setItem("userAge", input)
       
        /* Возраст отсутствовал в sessionStorage. Значит, это первый визит пользователя, и
         при прохождении проверки на возраст он увидит приветствие*/
        checker(true)
    }else{
  
        /* Пользователь заходит не первый раз, приветствие не показываем. */
        checker(false)
    }
   
    /* Вызываем переданную в качестве колл-бэка функцию логирования.
        передавать в качестве коллбека не обязательно, можно вызвать и напрямую.
    */
    logger()
 }


/*
* Проверка возраста пользователя
* */
let checker = function ( newVisit ){
    if(window.sessionStorage.getItem("userAge") >= 18 ){
        // Добавим проверку на первое посещение, чтобы не показывать приветствие
        // лишний раз
        if(newVisit){
            alert("Приветствуем на LifeSpot! " + '\n' +  "Текущее время: " + new Date().toLocaleString() );
        }
    }
    else{
        alert("Наши трансляции не предназначены для лиц моложе 18 лет. Вы будете перенаправлены");
        window.location.href = "http://www.yandex.ru"
    }
 }


/*
* Вывод данных сессии в консоль
* */
let logger = function () {
    console.log('Начало сессии: ' + window.sessionStorage.getItem("startDate") )
    console.log('Даныне клиента: ' + window.sessionStorage.getItem("userAgent") )
    console.log('Возраст пользователя: ' + window.sessionStorage.getItem("userAge"))
 }




