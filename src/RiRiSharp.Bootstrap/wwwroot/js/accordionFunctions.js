const togglingState = new WeakMap();

// Public versions (with locking)
export function toggle(accordionItemReference, alwaysOpen = false) {
    console.log(alwaysOpen);
    const collapseElement = accordionItemReference.querySelector('.accordion-collapse');
    const buttonElement = accordionItemReference.querySelector('.accordion-button');
    if (!collapseElement || !buttonElement || togglingState.get(collapseElement)) return;

    togglingState.set(collapseElement, true);

    const isCollapsed = buttonElement.classList.contains('collapsed');
    updateButtonState(buttonElement, !isCollapsed);

    const collapseInstance = bootstrap.Collapse.getOrCreateInstance(collapseElement);
    collapseInstance.toggle();

    if (!alwaysOpen) {
        const accordionParent = accordionItemReference.closest('.accordion');
        if (accordionParent) {
            const otherItems = Array.from(accordionParent.querySelectorAll('.accordion-item'))
                .filter(item => item !== accordionItemReference);
            otherItems.forEach(collapseInt); // use internal version
        }
    }

    const clearState = () => togglingState.set(collapseElement, false);
    collapseElement.addEventListener('shown.bs.collapse', clearState, {once: true});
    collapseElement.addEventListener('hidden.bs.collapse', clearState, {once: true});
}

export function show(accordionItemReference) {
    const collapseElement = accordionItemReference.querySelector('.accordion-collapse');
    if (!collapseElement || togglingState.get(collapseElement)) return;

    togglingState.set(collapseElement, true);
    showInt(accordionItemReference);

    collapseElement.addEventListener('shown.bs.collapse', () => {
        togglingState.set(collapseElement, false);
    }, {once: true});
}

export function collapse(accordionItemReference) {
    const collapseElement = accordionItemReference.querySelector('.accordion-collapse');
    if (!collapseElement || togglingState.get(collapseElement)) return;

    togglingState.set(collapseElement, true);
    collapseInt(accordionItemReference);

    collapseElement.addEventListener('hidden.bs.collapse', () => {
        togglingState.set(collapseElement, false);
    }, {once: true});
}

export function registerCollapseCallback(hasCollapseElementReference, hasCollapseDotNetRef) {
    if (!hasCollapseElementReference) return;

    let parent = hasCollapseElementReference.closest('.accordion-item');
    if (!parent) return;

    // Find the collapse element inside that item
    let collapseEl = parent.querySelector('.accordion-collapse');
    if (!collapseEl) return;

    collapseEl.addEventListener('shown.bs.collapse', () => {
        hasCollapseDotNetRef.invokeMethodAsync('UpdateCollapseState', false);
    });

    collapseEl.addEventListener('hidden.bs.collapse', () => {
        hasCollapseDotNetRef.invokeMethodAsync('UpdateCollapseState', true);
    });
}

function updateButtonState(buttonElement, isCollapsed) {
    if (buttonElement) {
        buttonElement.setAttribute('aria-expanded', String(!isCollapsed));
        buttonElement.classList.toggle('collapsed', isCollapsed);
    }
}

// Internal versions (no locking)
function showInt(accordionItemReference) {
    const collapseElement = accordionItemReference.querySelector('.accordion-collapse');
    const buttonElement = accordionItemReference.querySelector('.accordion-button');
    if (!collapseElement || !buttonElement) return;

    const collapseInstance = bootstrap.Collapse.getOrCreateInstance(collapseElement, {toggle: false});
    collapseInstance.show();

    updateButtonState(buttonElement, false);
}

function collapseInt(accordionItemReference) {
    const collapseElement = accordionItemReference.querySelector('.accordion-collapse');
    const buttonElement = accordionItemReference.querySelector('.accordion-button');
    if (!collapseElement || !buttonElement) return;

    const collapseInstance = bootstrap.Collapse.getOrCreateInstance(collapseElement, {toggle: false});
    collapseInstance.hide();

    updateButtonState(buttonElement, true);
}