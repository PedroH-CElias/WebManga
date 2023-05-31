@ModelType WebManga.Usuario
@Code
    ViewData("Title") = "Details"
End Code

<h2>Detalhes do Usuário</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.senha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.senha)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.cpf)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.cpf)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.idade)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.idade)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.profissao)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.profissao)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Voltar à lista", "Index")
</p>
