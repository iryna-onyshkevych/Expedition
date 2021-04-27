// //modal reg
// var btn = document.getElementById('btn-id-foot');
// var modal = document.getElementById('modal');
// var close = document.getElementsByClassName("close")[0];

// btn.onclick = function(){
//     document.getElementById('modal').style.display = 'block';
// }

// close.onclick = function(){
//     document.getElementById('modal').style.display = 'none';
// }

// //modal user
// var authorization = document.getElementById('authorization');
// var modaluser = document.getElementById('modal-user');
// var clos = document.getElementById('clos');
// authorization.onclick = function(){
//     document.getElementById('modal-user').style.width = '100%';
// }
// clos.onclick = function(){
//     document.getElementById('modal-user').style.width = '0px';
// }
//menu mobile
var imgmenu = document.getElementById('img-menu');
var menucontentmobile = document.getElementById('menu-content-mobile');
var cl = document.getElementById('cl');

imgmenu.onclick = function(){
    menucontentmobile.style.width = '100%';
}
cl.onclick = function(){
    menucontentmobile.style.width = '0%';
}
