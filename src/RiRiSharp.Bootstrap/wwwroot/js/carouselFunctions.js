export function moveToSlide(carouselRef, slideNumber) {
    if (!carouselRef) return;
    const carousel = bootstrap.Carousel.getOrCreateInstance(carouselRef);
    carousel.to(slideNumber);
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
