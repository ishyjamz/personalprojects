import React, { useState } from 'react'
import { Todo } from '../model'
import { AiFillEdit, AiFillDelete } from 'react-icons/ai'
import { MdDone } from 'react-icons/md'
import './styles.css'
import TodoList from './TodoList'


interface Props {
  todo: Todo;
  todos: Array<Todo>
  setTodos: React.Dispatch<React.SetStateAction<Array<Todo>>>;
}

const SingleTodo = ({ todo, todos, setTodos }: Props) => {
  
  const [edit, setEdit] = useState<boolean>(false);
  const [editTodo, setEditTodo] = useState<string>(todo.todo);

  // const handleEdit = (id: number) => {
  //   setTodos(
  //     todos.map(() => 
  //   )
  // }

  const handleDone = (id: number) => {
    setTodos(
      todos.map((todo) => todo.id === id ? { ...todo, isDone: !todo.isDone } : todo)
    );
  };

  const handleDelete = (id: number) => {
    setTodos(
      todos.filter((todo) => todo.id !== id)
      );
  }

  return (
    <form className='todos-single'>
      {edit ? (
          <input value={editTodo} onChange={(e) => setEditTodo(e.target.value)} className='todos-single-text'></input>
        ) : todo.isDone ? (
        <span className='todos-single-text'> {todo.todo} </span>
      ) : (
        <s className='todos-single-text'> {todo.todo} </s>
      )}


      <div>
        <span className='icon' onClick={() => {
          if (!edit && todo.isDone) {
          setEdit(!edit);
        }}}>
          <AiFillEdit />
        </span>
        <span className='icon' onClick = {() => handleDelete(todo.id)}>
          <AiFillDelete />
        </span>
        <span className='icon' onClick={() => handleDone(todo.id)}>
          <MdDone />
        </span>
      </div>
    </form>
  )
}

export default SingleTodo
