import { on, $1 } from "@servicestack/client"

function hideSidebar() {
    document.body.setAttribute('data-collapsed', 'true')
}
function toggleSidebar() {
    let collapsed = document.body.getAttribute('data-collapsed')
    if (collapsed) {
        document.body.removeAttribute('data-collapsed')
    } else {
        hideSidebar()
    }
}

export function bind() {
    on('[data-toggle-sidebar]', {
        click: toggleSidebar
    })
    hideSidebar()
}

document.addEventListener('DOMContentLoaded', () =>
    Blazor.addEventListener('enhancedload', hideSidebar))