const popoverTriggerList = document.querySelectorAll('[data-bs-toggle="popover"]');
const popoverList = [...popoverTriggerList].map(popoverTriggerEl => new bootstrap.Popover(popoverTriggerEl));

/* Collpase */
const searchColapse = document.getElementById('search-colapse');
if (searchColapse) {
    searchColapse.addEventListener('hidden.bs.collapse', event => {
        this.clasList.toggle('active');
    })

}

/* Theme  */
var html = document.documentElement;
var dark = document.querySelectorAll('#btnSwitch  input')[0];
var themeStorage = localStorage.getItem('data-bs-theme')
html.setAttribute('data-bs-theme', themeStorage);
if (themeStorage == 'dark') dark.checked = true;
document.getElementById('btnSwitch').addEventListener('click', () => {

    if (dark.checked) {
        html.setAttribute('data-bs-theme', 'dark');
        localStorage.setItem('data-bs-theme', 'dark');
    }
    else {
        html.setAttribute('data-bs-theme', 'light');
        localStorage.setItem('data-bs-theme', 'light');
    }
});


/* Filter list */
var listaOpcionais = document.querySelectorAll('#list-opcionais .list-group-item');
console.log(listaOpcionais);
var searchInput = document.getElementById('opcionais-search');
console.log(searchInput);

function filterList() {
    var input, filter, ul, li, a, i, txtValue;
    input = document.getElementById('opcionais-search');
    filter = input.value.toUpperCase();
    ul = document.getElementById('list-opcionais');
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        label = li[i].getElementsByTagName("label")[0];
        txtValue = label.textContent || label.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
}