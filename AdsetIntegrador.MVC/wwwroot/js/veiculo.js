function excluiVeiculo(veiculoId) {
    console.log(veiculoId)
    var opcoes = [];
    opcoes.push({ 'value': 'remover', 'text': 'Remover' });
    opcoes.push({ 'value': 'cancelar', 'text': 'Cancelar' });
    jOptions(
        'Este veículo será removido de sua loja.<br/>Tem certeza que deseja remover?',
        'Confirmação',
        opcoes,
        function (response) {
            if (response != 'cancelar') {

                $.ajax({
                    type: 'POST',
                    url: 'veiculo/Delete',
                    data: 'id=' + veiculoId,
                    dataType: 'json',
                   success: function (data) {
                        if (data.sucesso) {
                            alert('Veículo removido com sucesso!');
                            $('#list-cars').refresh();
                        }
                        else {
                            alert('Ocorreu um erro ao tentar remover o veículo, tente novamente!')
                        }
                    },
                    error: function (data) {
                        console.log(data);
                        alert('Ocorreu um erro ao tentar remover o veículo, tente novamente!');
                    }
                });
            }
        });
}