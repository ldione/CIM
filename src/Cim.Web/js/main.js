$( document ).ready(function() {

	//init Select style
	function selectInit(){
		var x, i, j, selElmnt, a, b, c;
		/*look for any elements with the class "custom-select":*/
		x = document.getElementsByClassName("custom-select");
		for (i = 0; i < x.length; i++) {
		  selElmnt = x[i].getElementsByTagName("select")[0];
		  /*for each element, create a new DIV that will act as the selected item:*/
		  a = document.createElement("DIV");
		  a.setAttribute("class", "select-selected");
		  a.innerHTML = selElmnt.options[selElmnt.selectedIndex].innerHTML;
		  x[i].appendChild(a);
		  /*for each element, create a new DIV that will contain the option list:*/
		  b = document.createElement("DIV");
		  b.setAttribute("class", "select-items select-hide");
		  for (j = 1; j < selElmnt.length; j++) {
		    /*for each option in the original select element,
		    create a new DIV that will act as an option item:*/
		    c = document.createElement("DIV");
		    c.innerHTML = selElmnt.options[j].innerHTML;
		    c.addEventListener("click", function(e) {
		        /*when an item is clicked, update the original select box,
		        and the selected item:*/
		        var y, i, k, s, h;
		        s = this.parentNode.parentNode.getElementsByTagName("select")[0];
		        h = this.parentNode.previousSibling;
		        for (i = 0; i < s.length; i++) {
		          if (s.options[i].innerHTML == this.innerHTML) {
		            s.selectedIndex = i;
		            h.innerHTML = this.innerHTML;
		            y = this.parentNode.getElementsByClassName("same-as-selected");
		            for (k = 0; k < y.length; k++) {
		              y[k].removeAttribute("class");
		            }
		            this.setAttribute("class", "same-as-selected");
		            break;
		          }
		        }
		        h.click();
		    });
		    b.appendChild(c);
		  }
		  x[i].appendChild(b);
		  a.addEventListener("click", function(e) {
		      /*when the select box is clicked, close any other select boxes,
		      and open/close the current select box:*/
		      e.stopPropagation();
		      closeAllSelect(this);
		      this.nextSibling.classList.toggle("select-hide");
		      this.classList.toggle("select-arrow-active");
		  });
		}
		function closeAllSelect(elmnt) {
		  /*a function that will close all select boxes in the document,
		  except the current select box:*/
		  var x, y, i, arrNo = [];
		  x = document.getElementsByClassName("select-items");
		  y = document.getElementsByClassName("select-selected");
		  for (i = 0; i < y.length; i++) {
		    if (elmnt == y[i]) {
		      arrNo.push(i)
		    } else {
		      y[i].classList.remove("select-arrow-active");
		    }
		  }
		  for (i = 0; i < x.length; i++) {
		    if (arrNo.indexOf(i)) {
		      x[i].classList.add("select-hide");
		    }
		  }
		}
		/*if the user clicks anywhere outside the select box,
		then close all select boxes:*/
		document.addEventListener("click", closeAllSelect);
	}

	function toggleMenu(){
		$('.hamburger').each( function( key, value ) {
		  $(value).toggleClass('open');
		});
		$('#js-menu').toggleClass('open');
		$('html').toggleClass('no-scroll');
	}

	function toggleSubMenu(e){
		e.preventDefault();
		var subMenu = $(this).parent().find('.sub-menu');

		if($(subMenu).hasClass('open')){
			$(subMenu).removeClass('open');
      		$(subMenu).css('max-height', '0px');
		}
		else{
			$('.sub-menu').removeClass('open');
  			$('.sub-menu').css('max-height', '0px');
			var subItems = $(subMenu).find('li');
			var height = 0;

			for (var i = $(subItems).length; i >= 0; i--) {
			height += $(subItems[i]).outerHeight();
			}
			$(subMenu).addClass('open');
			$(subMenu).css('max-height', height+'px');
		}
	}

	$('.hamburger').click(toggleMenu);
	$('.item.has-child>a').click(toggleSubMenu);

	var mySwiper = new Swiper ('.swiper-container', {
		// Optional parameters
		loop: true,
		slidesPerView: 4,
		spaceBetween: 50,
		navigation: {
			nextEl: '.swiper-button-next',
			prevEl: '.swiper-button-prev',
		},
		breakpoints: {
			992: {
				slidesPerView: 3,
				spaceBetween: 30
			},
			768: {
				slidesPerView: 1,
				spaceBetween: 0
			}
		},
    })

	// REINIT SLIDER WHEN RESIZE IS FINISH 
    var rtime;
	var timeout = false;
	var delta = 200;
	$(window).resize(function() {
	    rtime = new Date();
	    if (timeout === false) {
	        timeout = true;
	        setTimeout(resizeend, delta);
	    }
	});

	function resizeend() {
	    if (new Date() - rtime < delta) {
	        setTimeout(resizeend, delta);
	    } else {
	        timeout = false;
	        setTimeout(function(){
	        	mySwiper.update();
	        },200);
	    }               
	}

    $(window).scroll(function() {
	  if ($(this).scrollTop() > 0) {
	  	$('.contact-link').addClass("sticky");	
	  }
	  else{
	  	$('.contact-link').removeClass("sticky");	
	  }
	});

    var waypoints = $('.entry-anim').waypoint({
	  handler: function(direction) {
	    $(this.element).addClass('show');
	  },
	  offset: '60%'
	})

	/* Method to find href element of a div childs who had class ".jsBlockLink"
       -> Better for SEO */
      var $elem = $(".jsBlockLink");
      $elem.click(function(e) {
          var $link = $(this).find("a").not(".jsIgnoreBlockLink");
          if( $link.length ) {
              if( ($link.attr("target") && $link.attr("target") === "_blank") ||
                  e.ctrlKey ||
                  e.button === 1) {
                  window.open( $link.attr("href") );
              }
              else if (e.button === 0) {
                document.location.href = $link.attr("href");
              }
          }
        return false;
      });

	selectInit();
});



