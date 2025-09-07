export function toggle(accordionReference){
    const collapseElement = accordionReference.querySelector('.accordion-collapse');
    const collapseInstance = bootstrap.Collapse.getOrCreateInstance(collapseElement);
    collapseInstance.toggle();
}