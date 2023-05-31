@ModelType WebManga.Usuario
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Deletar Usuário</h2>

<h3>Você tem certeza que deseja deletar este usuário?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Deletar" class="btn btn-default" /> |
            @Html.ActionLink("Voltar à lista", "Index")
        </div>
    End Using
</div>
