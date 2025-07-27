# MemoryFlow AI

**MemoryFlow AI** is a free, open-source desktop application that provides a conversational interface to ChatGPT with persistent memory. Built using Avalonia UI and C#, it enables users to interact with AI naturally while simulating long-term memory across prompts — ideal for coding, writing, research, and more.

---

## 🧠 Problem It Solves

Large Language Models like ChatGPT are powerful, but they lack:

- **Persistent context across sessions**
- **Efficient memory of evolving tasks or discussions**
- **Support for iterative workflows without hitting token limits**
- **Local tools that allow natural, conversation-style iteration**

This app introduces a **persistent memory buffer** and a lightweight, cross-platform GUI that injects memory into each prompt — simulating continuity and context retention.

---

## 🛠️ Tooling

- **Avalonia UI** — Cross-platform desktop UI for Windows, Linux, macOS
- **.NET 8 / C#**
- **CommunityToolkit.MVVM** — Clean MVVM pattern with source generators
- **OpenAI API** — Uses the Chat Completions API (e.g., GPT-4o)
- **Markdown Rendering** — Responses are rendered in styled, readable Markdown
- **Memory Buffer** — Stored locally in `memory.md` or equivalent and injected per session

---

## 🧩 How It Works

1. User provides input (code, writing, questions, etc.)
2. MemoryFlow injects the latest memory into the prompt automatically
3. The assistant replies in Markdown with the relevant output
4. The memory file is **updated** with the new context or edited content
5. The session can continue iteratively with memory-aware responses

---

## 🧱 Architectural Pattern

MemoryFlow follows the **MVVM pattern** using **CommunityToolkit.MVVM**:

- `MainViewModel` handles prompt state, memory injection, and OpenAI interaction
- `MainView.axaml` binds directly to observable properties and commands
- Services handle memory loading/saving and HTTP calls to OpenAI

---

## 🔄 Key Features

- Simulated persistent memory via local files
- Natural back-and-forth chat with context
- Markdown and code rendering
- Iterative content refinement
- Cross-platform desktop experience
- Completely free and local — **you own your data**

---

## 💡 Use Cases

- 👨‍💻 **Software development** — evolve code, refactor classes, store context across iterations
- ✍️ **Writing assistant** — generate blog posts, technical documentation, creative writing
- 🧪 **Research agent** — store ongoing study notes or insights and build upon them
- 📚 **Academic and legal editing** — iterate over long documents while retaining style and structure
- 🧘 **Self-reflection and journaling** — retain conversation memory and mental models
- 📈 **Business workflows** — summarize meetings, plan tasks, keep running notes

---

## 📄 Licensing & Attribution

This tool is provided **free of charge**.

> ⚠️ This app uses the OpenAI Chat Completions API (e.g., GPT-4o) but is **not affiliated with or endorsed by OpenAI**.  
> "ChatGPT" is a trademark of OpenAI. Use is subject to their [brand guidelines](https://openai.com/brand).

---

## 🚧 Roadmap

- GUI memory editor
- Visual token estimation
- Multi-file memory grouping
- Offline LLM integration (Ollama or GPT4All backend)
- Themed personas / memory templates

---

## 🧠 Inspiration

Born from a common frustration: wanting to collaborate with ChatGPT on long or evolving tasks without restarting the conversation every time.

MemoryFlow AI gives you a smarter, smoother way to **work with AI — with memory**.
