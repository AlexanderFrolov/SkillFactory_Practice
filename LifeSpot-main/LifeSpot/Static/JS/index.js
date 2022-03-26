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

function startUserSession()
{
    session.set('userAgent', window.navigator.userAgent) 
}

function checkAge(){

    session.set('userAge', prompt('Введите ваш возраст: '))

    if (session.get('userAge') >= 18)
    {
        session.set('startDate', new Date().toLocaleString())
        alert('Добро пожаловать на LiveSpot! Время сейчас: ' + session.get('startDate'));
    }
    else
    {
        alert("Наши трансляции не предназначены для лиц моложе 18 лет. Вы будете перенаправлены");
        window.location.href = "http://yandex.ru"
    }
}

function printSessionLog(){
    
    for (let property of session){
        console.log(property)
    }
}



