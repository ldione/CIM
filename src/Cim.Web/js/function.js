;(function($, window, document, undefined) {
	var $win = $(window);
	var $doc = $(document);

	$doc.ready(function() {
		var counter = 0;
        
		$('.nav ul .has-dropdown').on('mouseover', function(){
			$this = $(this);
				
			if(counter == 0){
				$this.find('.first-item-dropdown').slideDown(300)	
				counter = 1;	
			}else{
				$this.find('.first-item-dropdown').show();
			}

			$('.body-layover-nav').addClass('active');
		});

		$('.nav ul .has-dropdown').on('mouseleave', function(){
				$(this).find('.first-item-dropdown').hide();
				$('.body-layover-nav').removeClass('active');
			
		});

		$('.nav ul').on('mouseleave', function(){
				counter = 0;
		});

		$('.sub-nav .first-li-has-dropdown > a').on('click' , function(e){ 
			e.preventDefault();
			$(this).parent().toggleClass('expanded');
			$(this).next('.sub-nav-dropdown').slideToggle(300);
		})

        $('.register .register-header .btn-scroll-down').on('click', function (e) {
            e.preventDefault();

            var scrollPosition = $(this).parent('.register-header').outerHeight() - 150;

            $('html,body').animate({
                scrollTop: scrollPosition
            }, 500);
        })

		//Toggle Search 
		$('.search-item i:first-child').on('click' , function(){
				if($(this).parent().hasClass('clicked')){ 
				
					$(this).attr('class' , 'far fa-search ico-search')
				
					$(this).parent().find('.search').removeClass('active');
				
					$(this).parent().removeClass('clicked')

					return;					
				}

				$(this).attr('class' , 'far fa-times ico-search')
				
				$(this).parent().find('.search').addClass('active');
				
				$(this).parent().addClass('clicked')
		})

		//On Blur validation
		$('.form-login .field , .form-register .field').on('blur', function(){
			var val = $(this).val();

			if(val != ''){
				$(this).next().addClass('active')
			}else{
				$(this).next().removeClass('active')
			}
		});

	
		$('.form-register .field').on('focus', function(){
			$(this).parents('.form-controls').find('.form-label').addClass('active')	
		});

		$('.form-register .field').on('blur', function(){
			var val = $(this).val();
			

			if(val != ''){
				$(this).parents('.form-controls').find('.form-label').addClass('active')

			}else{
				$(this).parents('.form-controls').find('.form-label').removeClass('active')

			}
			
		});

		//Password strenght indicator

		$(".reg-field-password").strength();

		//Show.hide password

		$(".show-hide-pass").on('click' , function(e){
			e.preventDefault();
			var type = $(this).parent().find('.field-password').attr('type');
			
			if(type == 'password'){
				$(this).parent().find('.field-password').attr('type' , 'text');
				$(this).find('i').attr('class' , 'fal fa-eye-slash');
			}else{
				$(this).parent().find('.field-password').attr('type' , 'password');
				$(this).find('i').attr('class' , 'fal fa-eye');
			}
		});

		$('.field-confirm-password').on('keyup' , function(){
			if($(this).val() == $('.reg-field-password').val()){
				$('.pass-check.correct-pass').show(300);
				$('.pass-check.incorrect-pass').hide(300);
			}else{
				$('.pass-check.correct-pass').hide(300);
				$('.pass-check.incorrect-pass').show(300);
			}
		})

		$('.membership .btn-main').on('click' , function(e){
			e.preventDefault();

			$('.cart-popup, .body-layover').addClass('active');
		});

		$('.btn-close-cart').on('click' , function(e){
			e.preventDefault();

			$('.cart-popup, .body-layover').removeClass('active');
		});

		//Show/Hide Login Wrapper
		$('.btn-login').on('click', function(e){
			e.preventDefault();

			$('.login-wrapper').addClass('expanded');
			$('.body-layover').addClass('active');

		})

		$('.btn-close-login	').on('click', function(e){
			e.preventDefault();

			$('.login-wrapper').removeClass('expanded');
			$('.body-layover').removeClass('active');
		})

		$('.tabs-nav a').on('click' , function(e){
			e.preventDefault();
	          $(this).parent().addClass('active')
	                 .siblings().removeClass('active');

	          var target = $(this).attr('href');
	          
	          
	          $(this).parents('.tabs-head').next().find('.tab').removeClass('active');
	          $(target).addClass('active');

	          var currentTabHeight = ($('.tabs-account .tab.active').height());

             $('.tabs-account .tabs-body').css('min-height' , currentTabHeight);

	});	

		$('.tabs-inner-nav a').on('click' , function(e){
             e.preventDefault();
             $(this).parent().addClass('active')
                    .siblings().removeClass('active');

             var target = $(this).attr('href');
             
             
             $(this).parents('.tabs-inner-head').next().find('.tab-inner').removeClass('active');
             $(target).addClass('active');
             
             

             var currentTabHeight = ($('.tab-inner.active').height());

             $('.tabs .tabs-inner-body').css('min-height' , currentTabHeight);
                    
         });

		$('.account-box-head').on('click' , function(){
			$(this).toggleClass('active');
			if($(this).next().is(':visible')){
				$(this).next().slideUp(300);	
			}else{
				$(this).next().slideDown(300);	
			}
			
		});

		$( "#sortable1, #sortable2" ).sortable({ 
      		connectWith: ".list-soc-items"
    	});

    	$('.add-button').on('click' , function(e) {
    		e.preventDefault();
    		var choosenSoc = $('#sortable2 .society-item-text');

    		$.each(choosenSoc , function(key , value){
    			$('#field-societies-select').append('<option value = ' + key +'> ' + value.innerText +' </option>');
    		})

    	})

        if ($('.tabs-inner-head').length) {
            $win.scroll(function () {


                var length = $('.tabs-inner-head').height() - $('.tabs-inner-nav').height() + $('.tabs-inner-head').offset().top;

                $(window).scroll(function () {

                    var scroll = $(this).scrollTop() + 200;
                    var height = $('.tabs-inner-nav').height() + 'px';

                    if (scroll < $('.tabs-inner-head').offset().top) {

                        $('.tabs-inner-nav').css({
                            'position': 'absolute',
                            'top': '0'
                        });

                    } else if (scroll > length) {

                        $('.tabs-inner-nav').css({
                            'position': 'absolute',
                            'bottom': '0',
                            'top': 'auto'
                        });

                    } else {

                        $('.tabs-inner-nav').css({
                            'position': 'fixed',
                            'top': '200px',
                            'height': height
                        });
                    }
                });

            });
        }

		});	
})(jQuery, window, document);
