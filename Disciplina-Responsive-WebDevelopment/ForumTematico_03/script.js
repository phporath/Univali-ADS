var listItems = document.querySelectorAll("button");

listItems.forEach(function(item) {
    item.onclick = function(e) {
       console.log(this.innerText); 
       document.getElementById('page').innerText = this.innerText;
    }
  });