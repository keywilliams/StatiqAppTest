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
}