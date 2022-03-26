function getReview() {

    let userReview = {};
   
    userReview["userName"] = prompt("Введите ваше имя:")
    if(userReview["userName"] == null){
        return
    }
   
    userReview["textReview"] = prompt("Оставьте свой отзыв")
    if(userReview["textReview"] == null){
        return
    }
   
    userReview["date"] = new Date().toLocaleString()
   
    addReviewOnAboutPage(userReview);
 }

 const addReviewOnAboutPage = userReview => {

    document.getElementsByClassName('reviews')[0].innerHTML += 
    '<p>' + userReview['userName'] + ' ' + userReview['date'] + '</p> <p>' + 
        userReview['textReview'] + '</p>';
 }