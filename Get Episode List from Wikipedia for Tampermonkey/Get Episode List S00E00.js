// ==UserScript==
// @name         Get Episode List S00E00 
// @namespace    http://tampermonkey.net/
// @version      0.1
// @description  try to take over the world!
// @author       You
// @match        https://en.wikipedia.org/*
// @grant        none
// ==/UserScript==

(function() {
    var  v = document.getElementsByClassName('summary');
    var elist=[];
    for(var i = 0; i < v.length;i++){
        elist[i] = v[i].innerHTML+ "<br/>";
    }



    var div1 = document.getElementById("content");
	var title = document.title;//document.getElementsByTagName("title").innerHTML;

    var btn = document.createElement("Input");
    btn.setAttribute("type", "button");
    btn.setAttribute("id", "showEpisodes");
    btn.setAttribute("value", "Show Episodes");
    btn.setAttribute("onclick", "Bu()");
    div1.insertBefore(btn,div1.firstElementChild);


	
    var prifix = document.createElement("Input");
    prifix.setAttribute("id", "PrifixId");
    prifix.setAttribute("type", "text");
    prifix.setAttribute("value", "S01");
    prifix.setAttribute("style","width: 50px;");
    div1.insertBefore(prifix,div1.firstElementChild);



    var startFrom = document.createElement("Input");
    startFrom.setAttribute("id", "startFromId");
    startFrom.setAttribute("type", "number");
    startFrom.setAttribute("value", 1);
    startFrom.setAttribute("title", "SP");
    startFrom.setAttribute("style","width: 50px;");
    div1.insertBefore(startFrom,div1.firstElementChild);
    
    var prifixName = document.createElement("Input");
    prifixName.setAttribute("id", "PrifixNameId");
    prifixName.setAttribute("type", "text");
    prifixName.setAttribute("value", title );
    prifixName.setAttribute("style","width: 200px;");
    div1.insertBefore(prifixName,div1.firstElementChild);

	var prifixLabel2 = document.createTextNode("Name:");
    div1.insertBefore(prifixLabel2,document.getElementById('PrifixNameId'));

    var prifixLabel1 = document.createTextNode("  Prifix:");
    div1.insertBefore(prifixLabel1,document.getElementById('PrifixId'));



    var prifixLabel = document.createTextNode("  Start At:");
    div1.insertBefore(prifixLabel,document.getElementById('startFromId'));
	



  
    Bu = function(){

        var prifixNm = document.getElementById('PrifixNameId').value;
        var startFrom1 = document.getElementById("startFromId").value -1;
        var prifix1 = (document.getElementById("PrifixId").value + "E");
       // var startPoint = prifix1-startFrom1;
       var startPoint = (-1)*startFrom1;

        if(prifixNm !== ""){prifixNm = prifixNm + "_";}
        

        var popup = window.open();
        var data = "";
        for(var j = 1; j<= elist.length;j++){
            var temp = elist[j-1].split('<')[0];
            temp = temp.replace(/"/g, "");
            temp = temp.replace(/,/g, "-");
            var num = prifix1+pad(startPoint+j,2);

           // var element = document.createElement('div');
           // element.setAttribute('id', 'mydiv');

           // element.appendChild(document.createTextNode(prifixNm+num+"_"+temp));
           // var win = popup.document.body;
           // win.appendChild(element);
            
            data += prifixNm+num+"_"+temp +"\n";
        }
        var element = document.createElement('textarea');
        element.setAttribute('id', 'copyEpisodeNames');
       
        element.setAttribute("rows", elist.length);
        element.setAttribute("cols", 100);
        var win = popup.document.body;
        win.appendChild(element);
        popup.window.document.getElementById('copyEpisodeNames').innerHTML = data;

    };
    
    function pad(num, size) {
    var s = num+"";
    while (s.length < size) s = "0" + s;
    return s;
}
})();
