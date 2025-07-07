namespace Exercicios_POO;
/******************************************************************************
Gerenciamento de tarefas
Objetivo: Criar uma classe para gerenciar uma lista de tarefas.
Requisitos:
Crie uma classe chamada GerenciadorDetarefas.
A classe GerenciadorDetarefas deve ter um atributo (campo) chamado tarefas que seja uma lista para armazenar as tarefas (strings). Inicialize esta lista como vazia no construtor.
Crie um método chamado Adicionartarefa(string tarefa) que adicione a tarefa especificada à lista de tarefas. O método deve imprimir uma mensagem confirmando a adição:
tarefa "[tarefa]" adicionada com sucesso.
Crie um método chamado Removertarefa(string tarefa) que remova a tarefa especificada da lista de tarefas. O método deve verificar se a tarefa existe na lista antes de removê-la.
Se a tarefa for encontrada e removida, o método deve imprimir uma mensagem de confirmação:
tarefa "[tarefa]" removida com sucesso.
Se a tarefa não for encontrada, o método deve imprimir uma mensagem de erro:
Erro: tarefa "[tarefa]" não encontrada na lista.
Crie um método chamado Listartarefas() que imprima todas as tarefas na lista, numerando-as. Se a lista estiver vazia, o método deve imprimir uma mensagem informando que não há tarefas.
Lista de tarefas: 1. [tarefa 1] 2. [tarefa 2] ...
ou
Não há tarefas na lista. 
No método Main do seu programa, crie um objeto da classe GerenciadorDetarefas.
Realize as seguintes operações no gerenciador de tarefas:
Adicione algumas tarefas.
Liste as tarefas.
Remova uma tarefa existente.
Tente remover uma tarefa que não existe.
Liste as tarefas novamente para verificar as alterações.

*******************************************************************************/
using System;
using System.Collections.Generic;

class TaskManager {
   // public String[] task = new String[];
   public List<String> task = new List<String>();
    
    public void AddTask(String task) {
        this.task.Add($"{task}");
        Console.WriteLine($"\"{task}\" adicionada com sucesso");
    }
    public void RemoveTask(String task) {
        for(int i = 0; i < this.task.Count; i++) {
            if(this.task[i] == task) {
                this.task.Remove($"{task}");
                Console.WriteLine($"task \"{task}\" removida com suceso");
                return;
            } else {
                Console.WriteLine($"Erro: task \"{task}\" não encontrada na lista.");
                return;
            }
        }
    }
    public void ListTask() {
        
        if(task.Count == 0) {
            Console.WriteLine("Não há tasks.");
        } else {
            for(int i = 0; i < this.task.Count; i++) {
                Console.WriteLine($"{i+1}. {this.task[i]} ");
            }
        }
    }
}