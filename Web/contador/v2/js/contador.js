/**
	Contador de dias ou de data
	@developer - Elvis de freitas
	@contact - contato@mageddo.com
	@version - 0.1
*/
var Contador = function(){
	this.dataCompleta = null;
	this.div = null;
}

/*
	@description - Conta os dias no intervalo entre as datas setadas
	@param diaInicial - String  ex: "16/12/2015"
	@param diaFinal - String  ex: "16/12/2015"
	@return - int dias faltantes
*/
Contador.prototype.contarEntreDatas = function(dataInicial, dataFinal){
	var diasInicial = this.milis2Dias(this.getDateP(dataInicial).getTime());
	var diasFinal =  this.milis2Dias(this.getDateP(dataFinal).getTime());
	return parseInt(diasFinal - diasInicial);
}
/*
	@description - Conta os dias no intervalo entre a data de hoje e a data setada
	@param diaFinal - String  ex: "16/12/2015"
	@return - int dias faltantes
*/
Contador.prototype.contarAteData = function(dataFinal){
	var diasFinal =  this.milis2Dias(this.getDateP(dataFinal).getTime());
	var diasInicial = this.milis2Dias(new Date().getTime());
	return parseInt(diasFinal - diasInicial +1);
	
}

/*
	@descrition - calcula o intervalo da data de hoje até a data setada
	e retorna um objeto com os dias, horas, minutos e segundos
	@param dataFinal  String ex: "12/02/2014"
	@return { dias=0, horas=9, minutos=38, segundos=23}
*/
Contador.prototype.contarComHoras = function(dataFinal){
	var di = new Date().getTime();
	var df = this.getDateP(dataFinal).getTime();
	return this.getDataFormatada(this.milis2Dias(df - di));
	
}

/*
	pega data formatada em dias faltantes e retorna um objeto com os valores
	@return { dias=0, horas=9, minutos=38, segundos=23}
*/
Contador.prototype.getDataFormatada = function(temp){
	var df = {};
	df.dias = parseInt(temp); // pegando dias
	temp = temp % 1; // pegando valor decimal
	temp *= 24; // convertando para horas
	df.horas = parseInt(temp); // pegando as horas
	temp = temp % 1; // pegando valor decimal
	temp *= 60; // convertando para minutos
	df.minutos = parseInt(temp); // pegando minutos
	temp = temp % 1; // pegando valor decimal
	temp *= 60; // convertando para segundos
	df.segundos = parseInt(temp); // pegando segundos
	return df;
}


// converte milisegundos para dias
Contador.prototype.milis2Dias = function(milis){
	return milis / 86400000;
}
// converte dias para milisegundos
Contador.prototype.dias2Milis = function(milis){
	return milis * 86400000;
}

/* Formata uma string de data e retorna um 
   objeto Date com a data que foi setada, este método é predefinido com o separador /
*/
Contador.prototype.getDateP = function(str){
	return this.getDate(str, "/");
}

/*
	returna uma div com uma classe de nome predefinido
	e variado pela string passada
*/
Contador.prototype.getNumeroVisual = function(number){
	return '<span class="dia number-'+number+'"></span>';
}
/* retorna uma span com a span com a classe
   do caractere ou conjunto que foram setados
   (esse método usar o getNumeroVisual a diferenã é apenas nominal)
*/
Contador.prototype.getCaracter = function(val){
	return this.getNumeroVisual(val);
}

/*
	Pega um número ou string de texto e gera uma span com a classe com o nome de 
	cada caractere ou unidade de numero setado no @param val
*/
Contador.prototype.getDateVisual = function(val){
	var strFinal = "";
	
	// convertendo inteiro para array de string
	val = new String(val);
	for(var k in val){
		strFinal += this.getNumeroVisual(val[k]);
	}	
	return strFinal;
}
/*
	cria elemento HTML para o contador e dispara o contador visualmente
	@param div - String seletor do elemento mãe
	@param val - int de dias faltantes
*/
Contador.prototype.setDateVisual = function(div, val){
	$(div).html(this.getDateVisual(this.contarAteData(val)));
}

/*
	verifica se a data ja passou
	@param number - array,objeto ou numero
*/
Contador.prototype.isEstourou = function(number){
	if(typeof number == "object"){
		var c = 0, i = 0;
		for(var k in number){
			i++;
			if(number[k] <= 0){c++;}
		}
		if(c == i) return true; else return false;
	}
	if(number <= 0)return false; else return true;
}

/* 
	Gera contador com dias, horas, minutos
	e segundos com base nos valores setados em @param setDateVisualComplete
*/
Contador.prototype.gerarVisualCompleto = function(){
	var str = "";
	var dataCompleta = this.contarComHoras(this.dataCompleta);
	
	// verifica se a data ja passou
	if(this.isEstourou(dataCompleta)){$(this.div).html("Chegou o dia!!");return false;}
	
	str += this.getDateVisual(dataCompleta.dias);
	str += this.getCaracter("space");
	str += this.getDateVisual(dataCompleta.horas);
	str += this.getCaracter("two-points");
	str += this.getDateVisual(dataCompleta.minutos);
	str += this.getCaracter("two-points");
	str += this.getDateVisual(dataCompleta.segundos);
	$(this.div).html(str);
	// rechamando este método
	setTimeout(this.gerarVisualCompleto.bind(this), 1000);
}

/* 
	De acordo os dados setados faz chamada do contador e aplica todos os 
	dados necessários
*/
Contador.prototype.setDateVisualComplete = function(div, val){
	this.div = div;
	this.dataCompleta = val;
	this.gerarVisualCompleto();
}

// recebe string de data no formato brasileiro e retorna uma instancia de Date
Contador.prototype.getDate = function(str, delimitador){
	var arrayData = [];
	arrayData = str.split(delimitador);
	
	switch(arrayData.length){
		case 3:
			return new Date(arrayData[2], arrayData[1]-1, arrayData[0]);
			break;
		case 6:
			return new Date(arrayData[2], arrayData[1]-1,arrayData[0], arrayData[3], arrayData[4], arrayData[5]);
			break;
		
		default:
			return new Date();
	}
}