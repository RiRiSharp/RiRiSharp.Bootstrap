export function dismiss(alertRef) {
    if (!alertRef) return;

    const alertInstance = bootstrap.Alert.getOrCreateInstance(alertRef);
    alertInstance.close();

}

export function registerDismissCallback(alertRef, alertDotNetRef) {
    if (!alertRef) return;

    alertRef.addEventListener('shown.bs.alert', () => {
        alertDotNetRef.invokeMethodAsync('UpdateDismissedState');
    });
}