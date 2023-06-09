﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebManga

Namespace Controllers
    Public Class UsuarioController
        Inherits System.Web.Mvc.Controller

        Private db As New MangaTecEntities

        ' GET: Usuario
        Function Index() As ActionResult
            Return View(db.Usuarios.ToList())
        End Function

        ' GET: Usuario/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuarios.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' GET: Usuario/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Usuario/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,email,senha,cpf,nome,idade,profissao")> ByVal usuario As Usuario) As ActionResult
            If ModelState.IsValid Then
                db.Usuarios.Add(usuario)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(usuario)
        End Function

        ' GET: Usuario/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuarios.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' POST: Usuario/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,email,senha,cpf,nome,idade,profissao")> ByVal usuario As Usuario) As ActionResult
            If ModelState.IsValid Then
                db.Entry(usuario).State = EntityState.Modified
                db.GetValidationErrors()
                db.SaveChanges()

                Return RedirectToAction("Index")
            End If
            Return View(usuario)
        End Function

        ' GET: Usuario/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuarios.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' POST: Usuario/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim usuario As Usuario = db.Usuarios.Find(id)
            db.Usuarios.Remove(usuario)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
