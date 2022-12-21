﻿function slick() {
    $('.slider-for').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        fade: true,
        arrows: true,
        prevArrow: '<div class="nav-prev"></div>',
        nextArrow: '<div class="nav-next"></div>',
        dots: true,
        adaptiveHeight: true,
        asNavFor: '.slider-nav',
        responsive: [
            {
                breakpoint: 600,
                settings: {
                    arrows: false, 
                }
            }
        ]
    });

    $('.slider-nav').slick({
        slidesToShow: 7.5,
        slidesToScroll: 1,
        asNavFor: '.slider-for',
        dots: false,
        arrows: false,
        focusOnSelect: true,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 5,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 576,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 1
                }
            }
        ]
    });

    $('.all-items').slick({
        dots: false,
        slidesToShow: 5,
        slidesToScroll: 1,
        centerMode: true,
        infinite: true,
        centerPadding: '10%',
        prevArrow: '<div class="nav-prev"></div>',
        nextArrow: '<div class="nav-next"></div>',
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1
                }
            }
        ]
    });

    $('.slider-for-all-episodes').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        fade: true,
        arrows: false,
        dots: false,
        asNavFor: '.slider-nav-all-episodes',
        responsive: [
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                }
            }
        ]
    });

    $('.slider-nav-all-episodes').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        asNavFor: '.slider-for-all-episodes',
        dots: false,
        arrows: false,
        focusOnSelect: true,
        vertical: true,
        verticalSwiping: true,
        responsive: [
            {
                breakpoint: 576,
                settings: {
                    slidesToShow: 2,
                    vertical:false
                }
            }
        ]
    });
}