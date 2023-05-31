@ModelType IEnumerable(Of WebManga.Usuario)
@Code
ViewData("Title") = "Index"
End Code

<h2>Usuários Cadastrados</h2>

<p>
    @Html.ActionLink("Cadastrar", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.senha)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.cpf)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.idade)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.profissao)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.senha)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.cpf)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.idade)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.profissao)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.id}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.id}) |
            @Html.ActionLink("Deletar", "Delete", New With {.id = item.id})
        </td>
    </tr>
Next

</table>
