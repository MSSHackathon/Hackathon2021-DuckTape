var Chart1;
var Chart2;
var Chart3;
var Chart4;
function generateChart(selector) {
    switch (selector) {
        case 0: var ctx = document.getElementById('Chart1').getContext('2d');
            Chart1 = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ['', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''], datasets: [{
                        label: 'Infizierte Einwohner',
                        data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], borderColor: 'rgba(255, 99, 132, 1)',
                        borderWidth: 1,
                        tension: 0.1
                    }]
                },
                options: {
                    legend: {
                        labels: {
                            fontColor: 'white',
                            fontSize: 18
                        }
                    },
                    scales: {
                        y: {
                            ticks: {
                                color: 'white',
                                fontSize: 18,
                                beginAtZero: true
                            }
                        },
                        x: {
                            ticks: {
                                color: 'white',
                                fontSize: 18,
                                beginAtZero: true
                            }
                        },
                    }
                }
            }); break;
        case 1: var ctx = document.getElementById('Chart2').getContext('2d');
            Chart2 = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ['', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''], datasets: [{
                        label: 'Genesene Einwohner',
                        data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], fontColor: 'white',
                        borderColor: 'rgba(255, 99, 132, 1)',
                        borderWidth: 1,
                        tension: 0.1
                    }]
                },
                options: {
                    legend: {
                        labels: {
                            color: 'white',
                            fontColor: "white",
                            fontSize: 18
                        }
                    },
                    scales: {
                        y: {
                            ticks: {
                                color: 'white',
                                fontSize: 18,
                                beginAtZero: true
                            }
                        }
                    }
                }
            }); break;
        case 2: var ctx = document.getElementById('Chart3').getContext('2d');
            Chart3 = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ['', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ''], datasets: [{
                        label: 'Gestorbene Einwohner',
                        data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
                        borderColor: 'rgba(255, 99, 132, 1)',
                        borderWidth: 1,
                        tension: 0.1
                    }]
                },
                options: {
                    legend: {
                        labels: {
                            color: 'white',
                            fontSize: 18
                        }
                    },
                    scales: {
                        y: {
                            ticks: {
                                color: 'white',
                                fontSize: 18,
                                beginAtZero: true
                            }
                        }
                    }
                }
            }); break;
        case 3: var ctx = document.getElementById('Chart4').getContext('2d');
            Chart4 = new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ['Niedersachsen', 'Sachsen', 'Thüringen', 'Berlin', 'Bremen', 'Hamburg', 'Nordrhein-Westfahlen', 'Mecklenburg-Vorpommern', 'Rheinland-Pfahlz', 'Bayern', 'Schleswig-Holstein', 'Barden-Württemberg', 'Hessen', 'Saarland', 'Brandenburg'],
                    datasets: [{
                        label: 'Infizierte Einwohner',
                        data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
                        borderColor: 'rgba(255, 99, 132, 1)',
                        borderWidth: 1,
                        tension: 0.1
                    }, {
                        label: 'Genesene Einwohner',
                        data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
                        borderColor: 'green',
                        borderWidth: 1,
                        tension: 0.1
                    }, {
                        label: 'Gestorbene Einwohner',
                        data: [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
                        borderColor: 'black',
                        borderWidth: 1,
                        tension: 0.1
                    }]
                },
                options: {
                    legend: {
                        labels: {
                            color: 'white',
                            fontSize: 18
                        }
                    },
                    scales: {
                        y: {
                            ticks: {
                                color: 'white',
                                fontSize: 18,
                                beginAtZero: true
                            }
                        }
                    }
                }
            }); break;
    }
}

function addData(selector, id, label, data) {
    console.log(data)
    switch (selector) {
        case 0:
            Chart1.data.labels.push('');
            Chart1.data.datasets[id].data.push(data);
            Chart1.update(); break;
        case 1:
            Chart2.data.labels.push('');
            Chart2.data.datasets[id].data.push(data);
            Chart2.update(); break;
        case 2:
            Chart3.data.labels.push('');
            Chart3.data.datasets[id].data.push(data);
            Chart3.update(); break;
        case 3:
            if (label) { Chart4.data.labels.push(''); }
            Chart4.data.datasets[id].data.push(data);
            Chart4.update(); break;
    }
}

function removeData(selector) {
    switch (selector) {
        case 0: Chart1.data.labels.pop();
            Chart1.data.datasets[0].data.splice(0, 10000000)
            Chart1.update(); break;
        case 1: Chart2.data.labels.pop();
            Chart2.data.datasets[0].data.splice(0, 10000000)
            Chart2.update(); break;
        case 2: Chart3.data.labels.pop();
            Chart3.data.datasets[0].data.splice(0, 10000000)
            Chart3.update(); break;
        case 3: Chart4.data.labels.pop();
            Chart4.data.datasets[0].data.splice(0, 10000000)
            Chart4.data.datasets[1].data.splice(0, 10000000)
            Chart4.data.datasets[2].data.splice(0, 10000000)
            Chart4.update(); break;
    }
}