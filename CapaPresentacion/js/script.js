//Introduce la fecha en el input de las vistas crear
const today = new Date().toISOString().slice(0, 10)

document.getElementById('date').value = today;