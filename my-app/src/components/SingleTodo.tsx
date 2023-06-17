import React from 'react'
import { Todo } from '../model'
import { AiFillEdit, AiFillDelete} from 'react-icons/ai'
import {MdDone} from 'react-icons/md'
import './styles.css'
import TodoList from './TodoList'


interface Props {
    todo: Todo;
    todos: Array<Todo>
    setTodos: React.Dispatch<React.SetStateAction<Array<Todo>>>;
}

const SingleTodo:React.FC<Props> = ({todo, todos, setTodos}) => {
    const handleDone = (id: number) => {
        setTodos(
            todos.map(todo) =>
            todo.id === id ? {...todo, isDone: !todo.isDone} : todo)
    };
  return (
    <form className='todos-single'>
      <span className='todos-single-text'>
        {todo.todo}
      </span>

      <div>
        <span className='icon'>
            <AiFillEdit/>
        </span>
        <span className='icon'>
            <AiFillDelete/>
        </span>
        <span className='icon' onClick={() => handleDone(todo.id)}>
            <MdDone/>
        </span>
      </div>
    </form> 
  )
}

export default SingleTodo
