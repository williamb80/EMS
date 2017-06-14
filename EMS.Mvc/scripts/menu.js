//Método inicia a cadeia de loop pelo json
//Ele recebe o menu completo
function BuildMenu (jsonMenu) {
    var menu = $("<ul class='dropdown-menu' role='menu' aria-labelledby='dropdownMenu'></ul>"); //Container principal do menu
    $.each(jsonMenu, function (index, itemMenu) {
        //Monta item a item do menu, quando pronto, adiciona no container principal
        menu.append(BuildMenuItem(itemMenu));
    });
    return menu;
};

//Método que vai criar cada item do menu
//Ele recebe um item de menu
BuildMenuItem = function (jsonMenu) {
    var itemMenu = $("<li></li>"); //Item do menu

    //Esse if é só pra deixar mais flexível, se existir link ele cria a tag <a>, do contrário cria o item do menu só com o nome
    if (jsonMenu.url) {
        itemMenu.append(CreateLink(jsonMenu.text, jsonMenu.url));
    }
    else {
        itemMenu.append(jsonMenu.text);
    }

    //Recursividade, se existir uma lista de submenu
    if (jsonMenu.sub && jsonMenu.sub.length > 0) {

        //Ele vai adicionar a esse menu o submenu completo, o submenu é o mesmo padrão que o menu completo, não muda a forma de contruí-lo
        //Então basta chamar o método novamente pra ele construir e devolver o submenu
        itemMenu.append(BuildMenu(jsonMenu.sub));
    }
    return itemMenu;
}

//Método helper, serve pra criar um link
CreateLink = function (text, url) {
    var link = $("<a></a>");
    link.append(text);
    link.attr("url", url);
    return link;
}

function Create() {
    $(function () {
        $.getJSON("/Menu/menuItens.json", function (menu) {
            $("#menu").append(BuildMenu(menu));
        });
    });
}