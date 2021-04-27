var imgmenu = document.getElementById('img-menu');
var menucontentmobile = document.getElementById('menu-content-mobile');
var cl = document.getElementById('cl');

imgmenu.onclick = function(){
    menucontentmobile.style.width = '100%';
}
cl.onclick = function(){
    menucontentmobile.style.width = '0%';
}
