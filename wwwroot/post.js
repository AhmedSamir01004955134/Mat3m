//icon open
let icon = document.querySelector('#item label');
let iconItem  = document.querySelector('#item');
icon.addEventListener('click',()=>{
  iconItem.classList.toggle('active')
}); 
//Draggable Icon
var dragItem = document.querySelector("#item");
    var draggableArea = document.querySelector(".draggable");

    var active = false;

    draggableArea.addEventListener("touchstart", dragStart, true);
    draggableArea.addEventListener("touchend", dragEnd, true);
    draggableArea.addEventListener("touchmove", drag, true);

    draggableArea.addEventListener("mousedown", dragStart, false);
    draggableArea.addEventListener("mouseup", dragEnd, false);
    draggableArea.addEventListener("mousemove", drag, true);

    function dragStart(e) {

        if (e.target !== e.currentTarget) {
          active = true;
            
          // this is the item we are interacting with
          activeItem = dragItem;
  
          if (activeItem !== null) {
            if (!activeItem.xOffset) {
              activeItem.xOffset = 0;
            }
  
            if (!activeItem.yOffset) {
              activeItem.yOffset = 0;
            }
  
            if (e.type === "touchstart") {
              activeItem.initialX = e.touches[0].clientX - activeItem.xOffset;
              activeItem.initialY = e.touches[0].clientY - activeItem.yOffset;
            } else {
              activeItem.initialX = e.clientX - activeItem.xOffset;
              activeItem.initialY = e.clientY - activeItem.yOffset;
            }
          }
        }
      }
  
      function dragEnd(e) {
        if (activeItem !== null) {
          activeItem.initialX = activeItem.currentX;
          activeItem.initialY = activeItem.currentY;
        }
  
        active = false;
        activeItem = null;
      }
  
      function drag(e) {
        if (active) {
          if (e.type === "touchmove") {
            e.preventDefault();
  
            activeItem.currentX = e.touches[0].clientX - activeItem.initialX;
            activeItem.currentY = e.touches[0].clientY - activeItem.initialY;
          } else {
            activeItem.currentX = e.clientX - activeItem.initialX;
            activeItem.currentY = e.clientY - activeItem.initialY;
          }
  
          activeItem.xOffset = activeItem.currentX;
          activeItem.yOffset = activeItem.currentY;
  
          setTranslate(activeItem.currentX, activeItem.currentY, activeItem);
        }
      }
  
      function setTranslate(xPos, yPos, el) {
        el.style.transform = "translate3d(" + xPos + "px, " + yPos + "px, 0)";
      }


//Filter Products Based On Categories
/* let categories = document.querySelectorAll('.categories .category');
let products = document.querySelectorAll('.product');
let popupMulti = document.querySelector('.multi-pop-up');
let popupMultiCategories = document.querySelectorAll('.multi-pop-up .category');
categories.forEach(category=>{
  category.addEventListener('click',()=>{
      let target = category.dataset.filter;
      products.forEach(product=>{
            if(product.dataset.target == target)
            {
                product.classList.add('active');
            }
            else
            {
              product.classList.remove('active');
            }
               
      });
  });
}); */
//filter Products Products Based On Products (Multi)
/* products.forEach(product=>{ 
    product.addEventListener('click',()=>{
      if (product.classList.contains('multi')) 
      {
          togglePopup(popupMulti)
          popupMultiCategories.forEach(mcategory=>
          {
                if(product.dataset.filter == mcategory.dataset.target)
                {
                    mcategory.classList.add('active');
                }
                else
                {
                  mcategory.classList.remove('active');
                }
             
          });
      }
    });       
});
//Handle Close On Click Multi
popupMultiCategories.forEach(mcategory=>{
    mcategory.addEventListener('click',()=>{
      togglePopup(popupMulti)
    });
}); */
//Close MULTI PopUP
let popupMultiClose = document.querySelector('.multi-pop-up .close');
/* closePopupButton(popupMultiClose,popupMulti) */

//Tabels Pop Up
let tablePopup = document.querySelector('.tabels-popup');
let tableButton = document.querySelector('.buttons .tables');
let CloseTablePopup = document.querySelector('.tabels-popup .close'); 
tableButton.addEventListener('click',()=>{
  togglePopup(tablePopup)
});
//Close TablePop Up
closePopupButton(CloseTablePopup,tablePopup)

//Handle Close On Click tables Numbers
let tableNumbers = document.querySelectorAll('.tabels-popup .t-number');
let t_Number = document.querySelector('.status span.number');
tableNumbers.forEach(tableNumber=>{
    tableNumber.addEventListener('click',()=>{
      togglePopup(tablePopup);
      t_Number.innerText = tableNumber.innerText
    });
});
//Handle Click on Icons
let orderButtons = document.querySelectorAll('.buttons .order-button');
let status = document.querySelector('.status span.type');
orderButtons.forEach(button=>{
    button.addEventListener('click',()=>{
        orderButtons.forEach(button=>button.classList.remove('active'));
        if(button.dataset.type!= "Tables")
        {
          button.classList.add('active');
          status.innerText = button.dataset.type;
          t_Number.innerText = "";
        }
    });
});
//Handle Click On Arrows 
/* let numberInput = document.querySelector('.result .row .input input')
let arrowUp = document.querySelector('.row-up')
let arrowDown = document.querySelector('.row-down');
arrowUp.addEventListener('click',()=>{
    numberInput.value = parseFloat(numberInput.value) + 1;
});
arrowDown.addEventListener('click',()=>{
    numberInput.value = numberInput.value - 1;
}); */

//Collapse Click
let collapse = document.querySelector('.collapse');
let buttonsContainer = document.querySelector('.buttons');
collapse.addEventListener('click',()=>{
    buttonsContainer.classList.toggle('collapsed')
});

//PopUp Functions
function togglePopup(item)
{
  item.classList.toggle('active');
}
function closePopupButton(close,popup)
{
    close.addEventListener('click',()=>{
      popup.classList.remove('active')
  });
}