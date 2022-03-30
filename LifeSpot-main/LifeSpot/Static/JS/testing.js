// let name = prompt('Введите ваше имя: ');
// alert(`Ваше имя : ${name}. В вашем имени: ${name.length} символов`);
//let elementsLength = document.getElementsByTagName('*').length;
//alert(`На странице : ${elementsLength} элементов.`);

function saveContext(){
    let newContext = document.getElementsByClassName('context')[0].value;
    alert('Предыдущий ввод: ' + this.lastContext + ' Текущий ввод: ' + newContext);
    this.lastContext = newContext;
}