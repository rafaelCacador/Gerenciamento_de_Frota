window.drawChart = (modelos, precos) => {
    var ctx = document.getElementById('carrosChart').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: modelos,
            datasets: [{
                label: 'Preço',
                data: precos,
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
};
