export function moveToSlide(carouselRef, slideNumber) {
    if (!carouselRef) return;
    const carousel = bootstrap.Carousel.getOrCreateInstance(carouselRef);
    console.log(carouselRef);
    carousel.to(slideNumber);
    console.log(carouselRef);

    // Update indicators: set 'active' on the button with data-bs-slide-to=slideNumber, because 
    // Bootstrap does not do this automatically when data-bs-target has not been set, which we purposefully avoid doing.
    const indicators = carouselRef.querySelectorAll('.carousel-indicators [type="button"]');
    indicators.forEach(btn => {
        if (btn.getAttribute('data-bs-slide-to') == slideNumber) {
            btn.classList.add('active');
        } else {
            btn.classList.remove('active');
        }
    });
}

export function moveNext(carouselRef) {
    if (!carouselRef) return;
    const carousel = bootstrap.Carousel.getOrCreateInstance(carouselRef);
    carousel.next();
}

export function movePrev(carouselRef) {
    if (!carouselRef) return;
    const carousel = bootstrap.Carousel.getOrCreateInstance(carouselRef);
    carousel.prev();
}
