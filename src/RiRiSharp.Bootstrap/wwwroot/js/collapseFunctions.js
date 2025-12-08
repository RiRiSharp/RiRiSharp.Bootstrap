export function collapse(collapseRef) {
    const collapse = getCollapseInstance(collapseRef);
    collapse.hide();
}

export function expand(collapseRef) {
    const collapse = getCollapseInstance(collapseRef);
    collapse.show();
}

export function toggle(collapseRef) {
    const collapse = getCollapseInstance(collapseRef);
    collapse.toggle();
}

export function dispose(collapseRef) {
    const collapse = getCollapseInstance(collapseRef);
    if (collapse) {
        collapse.dispose();
    }
}

function getCollapseInstance(collapseRef) {
    if (!collapseRef) return;
    return bootstrap.Collapse.getOrCreateInstance(collapseRef);
}