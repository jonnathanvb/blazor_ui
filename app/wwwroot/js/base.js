
function goBack() {
    window.history.back();
}


function graph(id, options) {
    var chart = new ApexCharts(document.querySelector(`#${id}`), options);
    chart.render();
}

var base = {
    goBack: goBack,
    graph: graph
}