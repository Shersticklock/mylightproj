 var btnL= document.getElementById('slider-left');
 var btnR= document.getElementById('slider-right');
 var pl = document.getElementById('polosa');
 btnL.onclick = sliderLeft;
 btnR.onclick = sliderRight;
 var left = 0;
 function sliderLeft() {
   left+= -128;
   if (left<-256) {
     left=-256;
   }
   pl.style.left = left + 'px';
 }
 function sliderRight() {
   left+= 128;
   if (left>0) {
     left=0;
   }
   pl.style.left = left + 'px';
 }
