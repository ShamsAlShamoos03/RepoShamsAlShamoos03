/* global bootstrap, SimpleLightbox */

window.addEventListener('DOMContentLoaded', () => {
    // ---------------------------
    // Navbar shrink function
    // ---------------------------
    // codacy:ignore Non-serializable expression
    const navbarShrink = () => {
        const navbarCollapsible = document.body.querySelector('#mainNav');
        if (!navbarCollapsible) return;

        if (window.scrollY === 0) {
            navbarCollapsible.classList.remove('navbar-shrink');
        } else {
            navbarCollapsible.classList.add('navbar-shrink');
        }
    };

    // Shrink the navbar initially
    navbarShrink();

    // Shrink the navbar when page is scrolled
    document.addEventListener('scroll', navbarShrink);

    // ---------------------------
    // Activate Bootstrap scrollspy
    // ---------------------------
    const mainNav = document.body.querySelector('#mainNav');
    if (mainNav && bootstrap) {  // تغییر: window.bootstrap -> bootstrap
        new bootstrap.ScrollSpy(document.body, {
            target: '#mainNav',
            rootMargin: '0px 0px -40%'
        });
    }

    // ---------------------------
    // Collapse responsive navbar when toggler is visible
    // ---------------------------
    const navbarToggler = document.body.querySelector('.navbar-toggler');
    const responsiveNavItems = Array.from(document.querySelectorAll('#navbarResponsive .nav-link'));

    responsiveNavItems.forEach(item => {
        item.addEventListener('click', () => {
            if (navbarToggler && window.getComputedStyle(navbarToggler).display !== 'none') {
                navbarToggler.click();
            }
        });
    });

    // ---------------------------
    // Activate SimpleLightbox for portfolio items
    // ---------------------------
    if (SimpleLightbox) {  // تغییر: window.SimpleLightbox -> SimpleLightbox
        new SimpleLightbox({
            elements: '#portfolio a.portfolio-box'
        });
    }
});