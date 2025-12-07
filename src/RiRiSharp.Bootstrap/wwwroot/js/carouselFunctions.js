export function moveToSlide(carouselRef, slideNumber) {
    const carousel = getCarouselInstance(carouselRef);
    carousel.to(slideNumber);
}

export function moveNext(carouselRef) {
    if (!carouselRef) return;
    const carousel = getCarouselInstance(carouselRef);
    carousel.next();
}

export function movePrev(carouselRef) {
    if (!carouselRef) return;
    const carousel = getCarouselInstance(carouselRef);
    carousel.prev();
}

export function cycle(carouselRef) {
    if (!carouselRef) return;
    const carousel = getCarouselInstance(carouselRef);
    carousel.cycle();
}

export function pause(carouselRef) {
    if (!carouselRef) return;
    const carousel = getCarouselInstance(carouselRef);
    carousel.pause();
}

export function addCycleCallback(carouselRef) {
    if (!carouselRef) return;
    if (carouselRef._cycleHandler) return;
    const carousel = getCarouselInstance(carouselRef);
    const cycleHandler = function () {
        carousel.cycle();
    };
    carouselRef._cycleHandler = cycleHandler;
    carouselRef.addEventListener('slid.bs.carousel', cycleHandler);
}

export function removeCycleCallback(carouselRef) {
    if (!carouselRef || !carouselRef._cycleHandler) return;
    carouselRef.removeEventListener('slid.bs.carousel', carouselRef._cycleHandler);
    delete carouselRef._cycleHandler;
}

function getCarouselInstance(carouselRef) {
    if (!carouselRef) return;
    const carousel = bootstrap.Carousel.getOrCreateInstance(carouselRef);
    addSlideCallback(carouselRef);
    return carousel;
}

// Set 'active' on the indicator buttons with data-bs-slide-to=slide.to 
// Bootstrap does not do this automatically when data-bs-target has not been set, which we purposefully avoid doing.
function addSlideCallback(carouselRef) {
    if (!carouselRef || carouselRef._indicatorSyncEnabled) return;

    carouselRef.addEventListener('slid.bs.carousel', function (event) {
        const indicators = carouselRef.querySelectorAll('.carousel-indicators [type="button"]');
        indicators.forEach(btn => {
            const attributeSlideNumber = parseInt(btn.getAttribute('data-bs-slide-to'));
            if (attributeSlideNumber === event.to) {
                btn.classList.add('active');
            } else {
                btn.classList.remove('active');
            }
        });
    });

    carouselRef._indicatorSyncEnabled = true;
}