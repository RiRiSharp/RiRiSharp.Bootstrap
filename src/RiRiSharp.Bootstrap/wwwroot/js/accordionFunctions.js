export function toggle(accordionReference) {
    const collapseElement = accordionReference.querySelector('.accordion-collapse');
    const collapseInstance = bootstrap.Collapse.getOrCreateInstance(collapseElement);
    collapseInstance.toggle();
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