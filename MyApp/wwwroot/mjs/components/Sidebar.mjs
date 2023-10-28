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

on('[data-toggle-sidebar]', {
    click: toggleSidebar
})

export default {
    load() {
        hideSidebar()
    }
}
