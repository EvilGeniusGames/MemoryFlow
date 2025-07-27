# MemoryFlow

**MemoryFlow** is a free, open-source desktop application that extends ChatGPT with simulated persistent memory. Built using Avalonia UI and C#, it enables users to work with ChatGPT more effectively across coding, writing, research, and other iterative tasks — all while maintaining memory across prompts.

---

## Problem It Solves

Large Language Models like ChatGPT are powerful, but they lack:

- Persistent context across sessions
- Efficient memory of evolving tasks or discussions
- Support for iterative workflows without hitting token limits
- Local tools that allow natural, conversation-style iteration

This app introduces a persistent memory buffer and a lightweight, cross-platform GUI that injects memory into each prompt — simulating continuity and context retention.

---

## Tooling

- Avalonia UI — Cross-platform desktop UI for Windows, Linux, macOS
- .NET 8 / C#
- CommunityToolkit.MVVM — Clean MVVM pattern with source generators
- OpenAI API — Uses the Chat Completions API (e.g., GPT-4o)
- Entity Framework Core — ORM for managing structured memory
- SQLite — Lightweight, file-based database used as the persistent backend
- Markdown Rendering — Responses are rendered in styled, readable Markdown

---

## How It Works

1. User provides input (code, writing, questions, etc.)
2. MemoryFlow injects the latest memory into the prompt automatically
3. The assistant replies in Markdown with the relevant output
4. The memory file and database are updated with new context
5. The session can continue iteratively with memory-aware responses

---

## Architectural Pattern

MemoryFlow follows the MVVM pattern using CommunityToolkit.MVVM:

- `MainViewModel` handles prompt state, memory injection, and OpenAI interaction
- `MainView.axaml` binds directly to observable properties and commands
- Services manage memory loading/saving, SQLite storage, and HTTP calls to OpenAI
- Entity Framework provides a structured persistence layer for memory and configuration

---

## Key Features

- Simulated persistent memory via local Markdown and database storage
- Natural back-and-forth chat with context
- Markdown and code rendering
- Iterative content refinement
- SQLite-backed memory management
- Cross-platform desktop experience
- Completely free and local — you own your data

---

## Use Cases

- Software development — evolve code, refactor classes, store context across iterations
- Writing assistant — generate blog posts, technical documentation, creative writing
- Research agent — store ongoing study notes or insights and build upon them
- Academic and legal editing — iterate over long documents while retaining style and structure
- Self-reflection and journaling — retain conversation memory and mental models
- Business workflows — summarize meetings, plan tasks, keep running notes

---

## Licensing & Attribution

This tool is provided free of charge.

This app uses the OpenAI Chat Completions API (e.g., GPT-4o) but is not affiliated with or endorsed by OpenAI.  
"ChatGPT" is a trademark of OpenAI. Use is subject to their [brand guidelines](https://openai.com/brand).

---

## Roadmap

- GUI memory editor
- Visual token estimation
- Multi-file memory grouping
- Offline LLM integration (Ollama or GPT4All backend)
- Themed personas / memory templates

---

## Inspiration

Born from a common frustration: wanting to collaborate with ChatGPT on long or evolving tasks without restarting the conversation every time.

MemoryFlow gives you a smarter, smoother way to work with AI — with memory.
