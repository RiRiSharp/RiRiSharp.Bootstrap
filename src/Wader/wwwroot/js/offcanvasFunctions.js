export function collapse(offcanvasRef) {
    const offcanvas = getOffcanvasInstance(offcanvasRef);
    if (collapse) {
        collapse.hide();
    }
}

export function show(offcanvasRef) {
    const offcanvas = getOffcanvasInstance(offcanvasRef);
    if (collapse) {
        collapse.show();
    }
}

export function toggle(offcanvasRef) {
    const offcanvas = getOffcanvasInstance(offcanvasRef);
    if (collapse) {
        collapse.toggle();
    }
}

export function dispose(offcanvasRef) {
    const offcanvas = getOffcanvasInstance(offcanvasRef);
    if (collapse) {
        collapse.dispose();
    }
}

function getOffcanvasInstance(offcanvasRef) {
    if (!offcanvasRef) return;
    
    return bootstrap.Offcanvas.getOrCreateInstance(offcanvasRef);
}