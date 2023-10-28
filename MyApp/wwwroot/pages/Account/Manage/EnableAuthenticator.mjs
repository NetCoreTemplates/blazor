import { addScript, $1 } from "@servicestack/client"
const loadJs = addScript('lib/js/qrcode.min.js')

export default {
    async load() {
        await loadJs
        function render() {
            new QRCode($1("#qrCode"), $1('#qrCodeData').getAttribute('data-url'))
        }
        render()
    }
}
